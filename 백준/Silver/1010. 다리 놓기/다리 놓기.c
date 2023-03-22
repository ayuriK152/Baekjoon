#include <stdio.h>

double factorial(double num)
{
	if (num == 1||num == 0)
		return 1;

	return num * factorial(num - 1);
}

double permutation(double n, double r)
{
	double temp = 1;
	for (r; r != 0; r--)
	{
		temp = temp * n;
		n--;
	}
	return temp;
}

int main()
{
	double countInput, firstInput, secondInput;
	double result;

	scanf("%lf", &countInput);

	while (countInput != 0)
	{
		scanf("%lf %lf", &firstInput, &secondInput);
		result = permutation(secondInput, firstInput) / factorial(firstInput);
		printf("%.0lf\n", result);
		countInput--;
	}


	return 0;
}