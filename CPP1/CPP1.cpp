#include<stdio.h>;
#include<stdlib.h>

#define OVERFLOW -2
#define OK 1
#define ERROR 0
#define ElemType int

// 定义结构体
typedef struct
{
	ElemType *elem; 
	int BSS;
	int size;
	int increment;
} SqStack;

// 初始化栈
int InitStack(SqStack& S, int size, int inc)
{
	S.elem = (ElemType*)malloc(size * sizeof(ElemType));
	if (NULL == S.elem) return OVERFLOW;
	S.BSS = 0;
	S.size = size;
	S.increment = inc;
	return OK;
}

// 入栈
int Push(SqStack& S, ElemType e)
{
	int* newbase;
	if (S.BSS >= S.size) {
		newbase = (ElemType*)realloc(S.elem, (S.size + S.increment) * sizeof(ElemType));
		if (NULL == newbase) return OVERFLOW;
		S.elem = newbase;
		S.size += S.increment;
	}
	S.elem[S.BSS++] = e;
	return OK;
}

// 倒置元素
void ReverseStack(SqStack& S)
{
	int i = 0, j = S.BSS - 1;
	while (i < j) {
		int temp = S.elem[i];
		S.elem[i] = S.elem[j];
		S.elem[j] = temp;
		i++;
		j--;
	}
}

// 打印
void PrintStack(SqStack& S)
{
	for (int i = S.BSS - 1; i >= 0; i--)
	{
		printf("%d ", S.elem[i]);
	}
}

int main()
{
	SqStack BSS;
	InitStack(BSS,50,1);
	//填充元素（从0-49的整数）
	for (int i = 8562;i <= 8812;i += 5) {
		Push(BSS, i);
	}
	//打印原栈
	printf("原栈：\n");
	PrintStack(BSS);
	printf("\n");

	//反转并打印
	printf("反转后栈：\n");
	ReverseStack(BSS);
	PrintStack(BSS);

	return 0;
}