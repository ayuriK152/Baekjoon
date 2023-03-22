#include <stdio.h>

int main()
{
	int a, b;
	int hund, ten, one;
	int result;

	scanf("%d%d", &a, &b);
	result = a * b;
	hund = b / 100;
	b = b - (b / 100 * 100);
	ten = b / 10;
	b = b - (b / 10 * 10);
	one = b / 1;
	printf("%d\n%d\n%d\n%d", a * one, a * ten, a * hund, result);
	return 0;
}