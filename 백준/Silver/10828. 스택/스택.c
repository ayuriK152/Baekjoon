#include <stdio.h>
#include <string.h>

void push(int stack[]);
void pop(int stack[]);
void size(int stack[]);
void empty(int stack[]);
void top(int stack[]);

int main()
{
	int stack[10000] = { 0, };
	int input, pushX;
	char command[10];

	scanf("%d", &input);

	for (int i = 1; i <= input; i++)
	{
		scanf("%s", command);

		if ((strcmp (command, "push")) == 0)
			push(stack);

		else if ((strcmp(command, "pop")) == 0)
			pop(stack);

		else if ((strcmp(command, "size")) == 0)
			size(stack);

		else if ((strcmp(command, "empty")) == 0)
			empty(stack);

		else if ((strcmp(command, "top")) == 0)
			top(stack);
	}

	return 0;
}

void push(int stack[])
{
	int num;
	int count = 0;

	getchar();
	scanf("%d", &num);

	while (1)
	{
		
		if (stack[count] == 0)
		{
			stack[count] = num;
			break;
		}
		count++;
	}
}

void pop(int stack[])
{
	int count = 0, temp;

	while (1)
	{
		if (stack[count] == 0)
		{
			if (count == 0)
				break;
			count--;
			break;
		}
		count++;
	}

	if (count == 0 && stack[count] == 0)
		printf("-1\n");

	else
	{
		temp = stack[count];
		stack[count] = 0;
		printf("%d\n", temp);
	}
}

void size(int stack[])
{
	int count = 0;

	while (1)
	{
		if (stack[count] == 0)
		{
			break;
		}
		count++;
	}

	printf("%d\n", count);
}

void empty(int stack[])
{
	if (stack[0] == 0)
		printf("1\n");
	else
		printf("0\n");
}

void top(int stack[])
{
	int count = 0;

	while (1)
	{
		if (stack[count] == 0)
		{
			if (count == 0)
				break;
			count--;
			break;
		}
		count++;
	}

	if (count == 0 && stack[count] == 0)
		printf("-1\n");

	else
		printf("%d\n", stack[count]);
}