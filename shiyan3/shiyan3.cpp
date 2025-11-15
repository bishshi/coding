#include<stdio.h>
#include<stdlib.h>

typedef struct Tree {
	char data;
	struct Tree *lchild;
	struct Tree *rchild;
} Tree;
 
// 初始化树
void initTree(Tree *T) {
	T->lchild = NULL;
	T->rchild = NULL;
	T->data = '0';
}

// 创建树
void CreateTree(Tree* T) { 
	int n = 0, m = 0, i = 0;
	if (T->data == '0') {
		printf("请输入该子树根节点的数据：");
		//getchar();
		//char x;
		scanf_s("%c", &T->data);
		getchar();                    
	}

	printf("节点%c是否有左子树（0：没有；1：有）:", T->data);
	scanf_s("%d", &n);
	getchar();

	if (n == 1) {
		Tree* lchild = (Tree*)malloc(sizeof(Tree));
		T->lchild = lchild;
		lchild->lchild = NULL;
		lchild->rchild = NULL;
		lchild->data = '0';
		CreateTree(T->lchild);

		printf("该节点%c是否存在右子树（0：没有； 1：有）：", T->data);
		scanf_s("%d", &i);
		getchar();

		if (i == 1) {
			Tree* rchild = (Tree*)malloc(sizeof(Tree));
			T->rchild = rchild;
			rchild->lchild = NULL;
			rchild->rchild = NULL;
			rchild->data = '0';
			CreateTree(T->rchild);
		}
	}
	else if (n == 0) {
		printf("节点%c是否有右子树（0：没有；1：有）:", T->data);
		scanf_s("%d", &m);
		getchar();

		if (m == 1) {
			Tree* rchild = (Tree*)malloc(sizeof(Tree));
			T->rchild = rchild;
			rchild->lchild = NULL;
			rchild->rchild = NULL;
			rchild->data = '0';
			CreateTree(T->rchild);
		}
	}
}

// 中序遍历
void LDR(Tree *T) {
	if (T != NULL) {
		LDR(T->lchild);
		printf("%c ", T->data);
		LDR(T->rchild);
	}
}

// 先序遍历
void DLR(Tree *T) {
	if (T != NULL) {
		printf("%c ", T->data);
		DLR(T->lchild);
		DLR(T->rchild);
	}
}

// 后序遍历
void LRD(Tree *T) {
	if (T != NULL) {
		LRD(T->lchild);
		LRD(T->rchild);
		printf("%c ", T->data);
	}
}

// 计算叶子节点个数
int leaves(Tree *T) {
	int count = 0;
	if (T == NULL) {
		return 0;
	}
	if (T->lchild == NULL && T->rchild == NULL) {
		count ++;
	} else {
		return leaves(T->lchild) + leaves(T->rchild);
	}
	return count;
}

// 计算树的深度
int depth(Tree *T) {
	int ldepth = 0, rdepth = 0;
	if (T == NULL) {
		return 0;
	} else {
		ldepth = depth(T->lchild);
		rdepth = depth(T->rchild);
		return (ldepth > rdepth) ? (ldepth + 1) : (rdepth + 1);
	}
}

// 计算树的节点个数
int nodes(Tree *T) {
	if (T == NULL) {
		return 0;
	} else {
		return nodes(T->lchild) + nodes(T->rchild) + 1;
	}
}

// 计算度为2的节点个数
int degree2nodes(Tree *T) {
	int count = 0;
	if (T == NULL) {
		return 0;
	}
	if (T->lchild != NULL && T->rchild != NULL) {
		count ++;
	}
	return count + degree2nodes(T->lchild) + degree2nodes(T->rchild);
}

int main() {
	Tree bss;
	initTree(&bss);

	CreateTree(&bss);
	printf("中序遍历结果为：\n");
	LDR(&bss);
	printf("\n先序遍历结果为：\n");
	DLR(&bss);
	printf("\n后序遍历结果为：\n");
	LRD(&bss);
	printf("\n叶子节点个数为：%d\n", leaves(&bss));
	printf("树的深度为：%d\n", depth(&bss));
	printf("树的节点个数为：%d\n", nodes(&bss));
	printf("度为2的节点个数为：%d\n", degree2nodes(&bss));
	return 0;
}