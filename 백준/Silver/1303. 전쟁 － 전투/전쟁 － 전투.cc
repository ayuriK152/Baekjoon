#include <queue>
#include <iostream>
#include <sstream>
using namespace std;

char arr[101][101];
int n, m;

class Pair
{
public:
	int x, y;

	Pair(int _x, int _y)
	{
		x = _x;
		y = _y;
	}
};

int BFS(Pair start) {
	queue<Pair*> q;
	q.push(&start);
	int count = 0;
	char team = arr[start.x][start.y];
	arr[start.x][start.y] = 'A';
	while (q.size() > 0) {
		Pair current = *q.front();
		q.pop();
		count++;
		if (current.x > 0) {
			if (arr[current.x - 1][current.y] == team) {
				arr[current.x - 1][current.y] = 'A';
				q.push(new Pair(current.x - 1, current.y));
			}
		}
		if (current.y > 0) {
			if (arr[current.x][current.y - 1] == team) {
				arr[current.x][current.y - 1] = 'A';
				q.push(new Pair(current.x, current.y - 1));
			}
		}
		if (current.x < n - 1) {
			if (arr[current.x + 1][current.y] == team) {
				arr[current.x + 1][current.y] = 'A';
				q.push(new Pair(current.x + 1, current.y));
			}
		}
		if (current.y < m - 1) {
			if (arr[current.x][current.y + 1] == team) {
				arr[current.x][current.y + 1] = 'A';
				q.push(new Pair(current.x, current.y + 1));
			}
		}
	}
	return count * count;
}

int main() {
	cin >> n >> m;
	string input;
	for (int i = 0; i < m; i++) {
		cin >> input;
		for (int j = 0; j < n; j++) {
			arr[j][i] = input[j];
		}
	}

	int countW = 0, countB = 0;
	for (int i = 0; i < m; i++) {
		for (int j = 0; j < n; j++) {
			if (arr[j][i] == 'W') {
				countW += BFS(*new Pair(j, i));
			}
			else if (arr[j][i] == 'B') {
				countB += BFS(*new Pair(j, i));
			}
		}
	}


	cout << countW << " " << countB;
	return 0;
}