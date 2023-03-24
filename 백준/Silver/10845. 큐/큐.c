#include <stdio.h>
#include <string.h>

void push(int arr[]);
int pop(int arr[]);
int size(int arr[]);
int empty(int arr[]);
int front(int arr[]);
int back(int arr[]);

int main()
{
	int queue[10000] = { 0, };
	int input;
	char cmd[10];

	scanf("%d", &input);
	for (int i = 0; i < input; i++)
	{
		scanf("%s", cmd);
		if (strcmp(cmd, "push") == 0)
			push(queue);
		else if (strcmp(cmd, "pop") == 0)
			printf("%d\n", pop(queue));
		else if (strcmp(cmd, "size") == 0)
			printf("%d\n", size(queue));
		else if (strcmp(cmd, "empty") == 0)
			printf("%d\n", empty(queue));
		else if (strcmp(cmd, "front") == 0)
			printf("%d\n", front(queue));
		else if (strcmp(cmd, "back") == 0)
			printf("%d\n", back(queue));
	}

	return 0;
}

void push(int arr[])
{
	int X, temp1 = -1, temp2 = -1;
	getchar();
	scanf("%d", &X);
	if (arr[0] == 0)
		arr[0] = X;
	else
	{
		temp1 = arr[0];
		arr[0] = X;
		for (int i = 1; temp2 != 0; i++)
		{
			temp2 = arr[i];
			arr[i] = temp1;
			temp1 = temp2;
		}
	}
}
int pop(int arr[])
{
	if (arr[0] == 0)
		return -1;
	else
	{
		int temp;
		temp = arr[size(arr) - 1];
		arr[size(arr) - 1] = 0;
		return temp;
	}
}
int size(int arr[])
{
	int count = 0;
	for (int i = 0; arr[i] != 0; i++)
		count++;
	return count;
}
int empty(int arr[])
{
	if (arr[0] == 0)
		return 1;
	else
		return 0;
}
int front(int arr[])
{
	if (arr[0] == 0)
		return -1;
	else
		return arr[size(arr) - 1];
}
int back(int arr[])
{
	if (arr[0] == 0)
		return -1;
	else
		return arr[0];
}