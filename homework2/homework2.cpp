#include<stdio.h>
#include<stdlib.h>

typedef int ElemType;

typedef struct {
	ElemType* elem; //基址
	int top;
	int size;
	int increment;
}SqStack;

