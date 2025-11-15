#include <stdio.h>
#include <stdlib.h>

#define TRUE 1
#define FALSE 0
#define queuesize 10
#define maxvernum 8

typedef struct queue {
	int elements[queuesize];
	int front;
	int rear;
} queue;

// 入队函数
int enQueue(queue* q, int value) {
	if ((q->rear + 1) % queuesize == q->front) {
		return FALSE;
	}
	q->elements[q->rear] = value;
	q->rear = (q->rear + 1) % queuesize;
	return TRUE;
}

// 出队函数
int deQueue(queue* q, int* value) {
	if (q->front == q->rear) {
		return FALSE;
	}
	*value = q->elements[q->front];
	q->front = (q->front + 1) % queuesize;
	return TRUE;
}

// 初始化队列
void initQueue(queue* q) {
	q->front = 0;
	q->rear = 0;
}

// 单链表节点定义
typedef struct Node {
	int data;
	struct Node* next;
} Node;

// 顶点结点（邻接表头）
typedef struct VexNode {
	int vexnum;
	Node* firstedge;
} VexNode;

// 邻接表
typedef struct AdjList {
	VexNode adjlist[maxvernum];
	int vexnum;
	int edgenum;
} AdjList;

// 定位顶点值
int locateVex(AdjList* G, int v) {
	for (int i = 0; i < G->vexnum; i++) {
		if (G->adjlist[i].vexnum == v) {
			return i;
		}
	}
	return -1;
}

// 创建有向图
void Creategraph(AdjList* g) {
	int i, k, v1, v2;
	printf("请输入顶点数和边数(空格分隔)：", maxvernum);
	scanf_s("%d %d", &g->vexnum, &g->edgenum);

	// 初始化顶点
	for (i = 0; i < g->vexnum; i++) {
		g->adjlist[i].vexnum = i + 1;
		g->adjlist[i].firstedge = NULL;
	}

	printf("当前顶点为：");
	for (i = 0; i < g->vexnum; i++) {
		printf("v%d ", g->adjlist[i].vexnum);
	}
	printf("\n");

	// 依次输入每条有向边（弧头 v1 -> 弧尾 v2），用空格分隔
	for (k = 0; k < g->edgenum; k++) {
		printf("请输入第%d条有向边的弧头 和 弧尾（用空格分隔）：", k + 1);
		scanf_s("%d %d", &v1, &v2);
		int i_idx = locateVex(g, v1);
		int j_idx = locateVex(g, v2);
		if (i_idx >= 0 && j_idx >= 0) {
			// 在 v1 的链表末尾加入 v2
			Node* bss = (Node*)malloc(sizeof(Node));
			if (!bss) {
				printf("内存分配失败");
				return;
			}
			bss->data = v2;
			bss->next = NULL;
			if (g->adjlist[i_idx].firstedge == NULL) {
				g->adjlist[i_idx].firstedge = bss;
			}
			else {
				Node* q = g->adjlist[i_idx].firstedge;
				while (q->next) q = q->next;
				q->next = bss;
			}
		}
		else {
			printf("顶点 %d 或 %d 不存在，边被忽略\n", v1, v2);
		}
	}

	// 输出邻接表
	printf("输出各个顶点的邻接表：\n");
	for (i = 0; i < g->vexnum; i++) {
		printf("顶点 v%d", g->adjlist[i].vexnum);
		Node* p = g->adjlist[i].firstedge;
		while (p) {
			printf(" --> v%d", p->data);
			p = p->next;
		}
		printf("\n");
	}
}

// 深度优先遍历
void DFS(AdjList* G, int v, int visited[]) {
	int i = locateVex(G, v);
	visited[i] = 1;
	printf("%d ", G->adjlist[i].vexnum);
	Node* p = G->adjlist[i].firstedge;
	while (p != NULL) {
		int j = locateVex(G, p->data);
		if (j != -1 && !visited[j]) {
			DFS(G, p->data, visited);
		}
		p = p->next;
	}
}

// 广度优先遍历
void BFS(AdjList* G, int v, int visited[]) {
	queue q;
	initQueue(&q);
	int i = locateVex(G, v);
	if (i == -1) return;
	visited[i] = 1;
	printf("%d ", G->adjlist[i].vexnum);
	enQueue(&q, v);
	int w;
	while (deQueue(&q, &w)) {
		int k = locateVex(G, w);
		if (k == -1) continue;
		Node* p = G->adjlist[k].firstedge;
		while (p != NULL) {
			int j = locateVex(G, p->data);
			if (j != -1 && !visited[j]) {
				visited[j] = 1;
				printf("%d ", G->adjlist[j].vexnum);
				enQueue(&q, p->data);
			}
			p = p->next;
		}
	}
}

int main() {
	AdjList G;
	Creategraph(&G);
	int visited[maxvernum] = { 0 };
	printf("深度优先遍历结果：");
	for (int i = 0; i < G.vexnum; i++) {
		if (!visited[i]) { 
			DFS(&G, G.adjlist[i].vexnum, visited);
		}
	}
	printf("\n");

	for (int i = 0; i < maxvernum; i++) visited[i] = 0;
	printf("广度优先遍历结果：");
	for (int i = 0; i < G.vexnum; i++) {
		if (!visited[i]) {
			BFS(&G, G.adjlist[i].vexnum, visited);
		}
	}

	return 0;
}
