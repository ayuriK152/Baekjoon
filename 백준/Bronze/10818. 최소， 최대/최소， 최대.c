#include <stdio.h>

int main()
{
	int num;
	int max, min;

	scanf("%d", &num);
	int *numArr = malloc(sizeof(int) * num);

	for (int i = 0; i <= num - 1; i++)
	{
		scanf("%d", &numArr[i]);
		getchar();
	}

	max = maxNum(num, numArr);
	min = minNum(num, numArr);

	printf("%d %d", min, max);

	return 0;
}

int maxNum(int count, int arr[])
{
	int temp;
	for (int i = 0; i <= count - 1; i++)
	{
		if (i == 0)
			temp = arr[i];
		else if (temp < arr[i])
			temp = arr[i];
	}

	return temp;
}

int minNum(int count, int arr[])
{
	int temp;
	for (int i = 0; i <= count - 1; i++)
	{
		if (i == 0)
			temp = arr[i];
		else if (temp > arr[i])
			temp = arr[i];
	}

	return temp;
}