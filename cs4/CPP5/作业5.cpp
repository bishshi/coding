#include<stdio.h>
#include<stdlib.h>
#include<time.h>

typedef struct Node
{
	int data;
	Node* next;
} Node;

// 链式基数排序
Node* radixSort(Node* head)
{
	if (head == NULL) return NULL;
	int max = head->data;
	Node* current = head;
	while (current != NULL)
	{
		if (current->data > max)  max = current->data;
		current = current->next;
	}
	// 基数排序
	for (int exp = 1; max / exp > 0; exp *= 10)
	{
		Node* buckets[10] = { NULL };
		Node* tails[10] = { NULL };
		current = head;
		while (current != NULL)
		{
			Node* next = current->next; // 保存下一个节点
			current->next = NULL;       // 断开，防止形成环或错连

			int digit = (current->data / exp) % 10;
			if (buckets[digit] == NULL)
			{
				buckets[digit] = current;
				tails[digit] = current;
			}
			else
			{
				tails[digit]->next = current;
				tails[digit] = current;
			}
			current = next;
		}
		Node* newHead = NULL;
		Node* newTail = NULL;
		for (int i = 0; i < 10; i++)
		{
			if (buckets[i] != NULL)
			{
				if (newHead == NULL)
				{
					newHead = buckets[i];
					newTail = tails[i];
				}
				else
				{
					newTail->next = buckets[i];
					newTail = tails[i];
				}
			}
		}
		if (newTail != NULL)
			newTail->next = NULL;
		head = newHead;
	}
	return head;
}

int main()
{
	srand((unsigned int)time(NULL));
	Node* head = NULL;
	for (int i = 0; i < 100000; i++)
	{
		Node* newNode = (Node*)malloc(sizeof(Node));
		newNode->data = rand() % 100;
		newNode->next = head;
		head = newNode;
	}
	printf("链表已创建！\n");
	double clock1 = clock();
	head = radixSort(head);
	double clock2 = clock();
	printf("排序完成:\n");
	printf("排序时间: %f 秒\n", (double)(clock2 - clock1) / CLOCKS_PER_SEC);
	return 0;
}