#include <stdio.h>
#include <stdlib.h>

#define Type int

// 定义哈希表
typedef struct HashTable {
    Type* table;
	int Length;
} HashTable;

// 哈希函数
int HashFunction(HashTable &HashTable,int key) {
    return key % HashTable.Length;
}

// 初始化哈希表
void initHashTable(HashTable &HashTable) {
    HashTable.table = (Type*)malloc(HashTable.Length * sizeof(Type));
    for (int i = 0; i < HashTable.Length; i++) {
        HashTable.table[i] = -1;
    }
}

// 线性探测再散列
void insert1(HashTable &HashTable, int key) {
    int index = HashFunction(HashTable, key);
    while (HashTable.table[index] != -1) {
        index = (index + 1) % HashTable.Length;
    }
    HashTable.table[index] = key;
}

// 二次探测再散列
void insert2(HashTable& HashTable, int key) {
    int index = HashFunction(HashTable, key);
    if (HashTable.table[index] == -1) {
        HashTable.table[index] = key;
		return;
    }

    for (int i = 1; i < HashTable.Length; ++i) {
        int sign = (i & 1) ? 1 : -1;
        int sq = (i + 1) / 2;
        int d = sign * sq * sq;
        int position = (index + d) % HashTable.Length;
        if (position < 0) position += HashTable.Length;
        if (HashTable.table[position] == -1) {
            HashTable.table[position] = key;
            return;
        }
    }
}

// 打印哈希表
void printHashTable(HashTable &HashTable) {
    for (int i = 0; i < HashTable.Length; i++) {
        if (HashTable.table[i] == -1) {
            printf("空 ");
        }
        else {
            printf("%d ", HashTable.table[i]);
        }
    }
}

int main()
{
    HashTable HashTable1, HashTable2;
    HashTable1.Length = 11;
    HashTable2.Length = 11;
    initHashTable(HashTable1);
    initHashTable(HashTable2);
    int keys[] = { 19, 1, 23, 14, 55, 68, 11, 82, 36 };
    int n = sizeof(keys) / sizeof(keys[0]);

    for (int i = 0; i < n; i++) {
        insert1(HashTable1, keys[i]);
    }

    for (int i = 0; i < n; i++) {
        insert2(HashTable2, keys[i]);
    }

    // 打印哈希表
	printf("线性探测再散列结果:\n");
    printHashTable(HashTable1);
	printf("\n");
	printf("二次探测再散列结果:\n");
    printHashTable(HashTable2);

    return 0;
}
