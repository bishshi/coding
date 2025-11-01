#include<stdio.h>
#include<stdlib.h>

#define ElemType int
#define OK 1
#define OVERFLOW 0

// 链表定义
typedef struct LNode{
	ElemType data;
	struct LNode* next;
} LNode, * LinkList;

// 初始化链表
int InitList(LinkList &L){
	L = (LNode*)malloc(sizeof(LNode));
	if (!L) return OVERFLOW;
	L->next = NULL;
	return OK;
}

// 生成新节点
LNode* MakeNode(ElemType e) {
    LNode* bss;
    bss = (LNode*)malloc(sizeof(LNode));
    if (bss != NULL) {
        bss->data = e;
        bss->next = NULL;
    }
    return bss;
}

// 插入节点
int Insert(LinkList &L, LNode* s){
    if (!L) return OVERFLOW;
    s->next = L->next;
    L->next = s;
    return OK;
}

// 创建链表
int CreatList(LinkList& L, int n, ElemType A[]){
    LNode* p, * q;
    int i;
    if (!InitList(L)) return OVERFLOW;
    p = L;
    for (i = 0; i < n; i++)
    {
        q = MakeNode(A[i]);
        Insert(p, q);
        p = q;
    }
    return OK;
}

// 合并链表
int MergeList(LinkList La, LinkList Lb, LinkList& Lc)
{
    LNode* pa, * pb, * pc;
    pa = La->next;
    pb = Lb->next;
    if (!InitList(Lc)) return OVERFLOW;
    pc = Lc;
    while (pa && pb)
    {
        if (pa->data <= pb->data)
        {
            pc->next = pa;
            pc = pa;
            pa = pa->next;
        }
        else
        {
            pc->next = pb;
            pc = pb;
            pb = pb->next;
        }
    }
    pc->next = pa ? pa : pb;
    return OK;
}

// 打印链表
int PrintList(LinkList L)
{
    LNode* p = L->next;
    while (p)
    {
        printf("%d ", p->data);
        p = p->next;
    }
    printf("\n");
    return OK;
}

int main()
{
    LinkList bss1, bss2, bss3;
    int A[] = { 253,342,465,586,678 };
    int B[] = { 787,895,996,1023,2096,3323 };
    CreatList(bss1, 5, A);
    CreatList(bss2, 6, B);
    printf("第一个链表: \n");
	PrintList(bss1);
    printf("第二个链表: \n");
	PrintList(bss2);
    MergeList(bss1, bss2, bss3);
	printf("合并后的链表: \n");
    PrintList(bss3);

	return 0;
}