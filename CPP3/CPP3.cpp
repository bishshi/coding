#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define RcdType int
#define OK 1
#define OVERFLOW 0

typedef struct {
	RcdType* rcd;
	int len;
	int size;
} RcdList;

int InitRcdList(RcdList& list,int size) {
	list.rcd = (RcdType*)malloc((size + 1) * sizeof(RcdType));
	list.len = 0;
	list.size = size + 1;
	if (NULL == list.rcd) return OVERFLOW;
}

void InsertSort(RcdList& list) {
	int i, j;
	for (i = 1;i < list.len; i++) {
		if (list.rcd[i + 1] < list.rcd[i]) {
			list.rcd[0] = list.rcd[i + 1];
			j = i + 1;
			do { j--, list.rcd[j + 1] = list.rcd[j];
			} while (list.rcd[0] < list.rcd[j - 1]);
			list.rcd[j] = list.rcd[0];
		}
	}
}


void ShellInsert(RcdList& L, int dk) {
	int i, j;
	for (i = 1; i < L.len - dk; ++i) {
		if (L.rcd[i + dk] < L.rcd[i]) {
			L.rcd[0] = L.rcd[i + dk];
			j = i + dk;
			do {
				j--, L.rcd[j + dk] = L.rcd[j];
			} while (j - dk > 0 && L.rcd[0] < L.rcd[j - dk]);
			L.rcd[j] = L.rcd[0];
		}
	}
}

void ShellSort(RcdList& L, int d[], int t) {
	int k;
	for (k = 0; k < t; ++k) ShellInsert(L, d[k]);
}

void PrintList(RcdList list) {
	for (int i = 1;i <= list.len;i++) {
		printf("%d ", list.rcd[i]);
	}
	printf("\n");
}

int main()
{
	//先十个数据
	RcdList bss;
	InitRcdList(bss, 10);
	for (int i = 1;i <= 11;i++) {
		bss.rcd[i] = rand() % 100;
		bss.len++;
	}
	printf("原始:\n");
	PrintList(bss);
	RcdList bss1 = bss;
	InsertSort(bss1);
	printf("直接插入排序结果:\n");
	PrintList(bss1);
	RcdList bss2 = bss;
	int d[3] = { 5,3,1 };
	ShellSort(bss2, d, 3);
	printf("希尔排序结果:\n");
	PrintList(bss2);

	//生成10000个数据，并统计执行时间
	RcdList bss3;
	InitRcdList(bss3, 100000);
	srand(time(NULL));  //以当前时间作为随机数种子
	for (int i = 1;i <= 100001;i++) {
		bss3.rcd[i] = rand() % 10000;
		bss3.len++;
	}
	RcdList bss4 = bss3;
	clock_t start1 = clock();
	InsertSort(bss4);
	clock_t end1 = clock();
	printf("100000个数据直接插入排序时间: %lf 秒 \n", (double)(end1 - start1) / CLOCKS_PER_SEC);

	RcdList bss5 = bss3;
	int d1[5] = { 5000,2000,1000,500,1 };
	clock_t start2 = clock();
	ShellSort(bss5, d1, 5);
	clock_t end2 = clock();
	printf("100000个数据希尔排序时间: %lf 秒 \n", (double)(end2 - start2) / CLOCKS_PER_SEC);
	
	return 0;

}