#include <stdio.h>

int main()
{
	int a, b, c;
	int result;
	scanf("%d%d%d", &a, &b, &c);

	result = (a + b) % c;
	printf("%d\n", result);

	result = ((a % c) + (b % c)) % c;
	printf("%d\n", result);

	result = (a * b) % c;
	printf("%d\n", result);

	result = ((a % c) * (b % c)) % c;
	printf("%d\n", result);
	return 0;
}