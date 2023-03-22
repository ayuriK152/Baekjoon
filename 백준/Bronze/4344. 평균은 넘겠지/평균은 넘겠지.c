#include<stdio.h>

int main()
{
	int caseCount;

	scanf("%d", &caseCount);

	for (int i = 1; i <= caseCount; i++)
	{
		avg();
	}

	return 0;
}

int avg(void)
{
	int student, overAvg = 0;
	float average = 0.0f;
	int score[1000];

	scanf("%d", &student);
	getchar();

	for (int j = 0; j <= student-1; j++)
	{
		scanf("%d", &score[j]);
		getchar();
		average += score[j];
	}
	
	average /= student;

	for (int k = 0; k <= student-1; k++)
	{
		if (score[k] > average)
			overAvg++;
	}

	printf("%.3f%%\n", 100 * overAvg / (float)student);
}