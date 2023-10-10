#include <iostream>
#include <string>
using namespace std;

int mat[300][300] = { 0 };
int matCpy[300][300] = { 0 };
int n, m, r;
int minX = 0, minY = 0, maxX, maxY;

void Change(int x, int y, int rotCnt) {
	int originX = x, originY = y;
	while (rotCnt > 0) {
		if (y < maxY && x == minX) {
			y += rotCnt;
			if (y > maxY) {
				rotCnt = y - maxY;
				y = maxY;
				continue;
			}
		}
		else if (y == maxY && x < maxX) {
			x += rotCnt;
			if (x > maxX) {
				rotCnt = x - maxX;
				x = maxX;
				continue;
			}
		}
		else if (y > minY && x == maxX) {
			y -= rotCnt;
			if (y < minY) {
				rotCnt = minY - y;
				y = minY;
				continue;
			}
		}
		else if (y == minY && x > minX) {
			x -= rotCnt;
			if (x < minX) {
				rotCnt = minX - x;
				x = minX;
				continue;
			}
		}
		rotCnt = 0;
	}

	matCpy[y][x] = mat[originY][originX];
}

int main() {
	cin >> n >> m >> r;
	for (int y = 0; y < n; y++)
		for (int x = 0; x < m; x++)
			cin >> mat[y][x];

	int layer = n < m ? n / 2 : m / 2;
	maxX = m - 1, maxY = n - 1;
	while (layer > 0) {
		for (int x = minX; x <= maxX; x++) {
			Change(x, minY, r);
			Change(x, maxY, r);
		}
		for (int y = minY + 1; y < maxY; y++) {
			Change(minX, y, r);
			Change(maxX, y, r);
		}
		minX++; minY++; maxX--; maxY--;
		layer--;	
	}

	string result = "";
	for (int y = 0; y < n; y++) {
		for (int x = 0; x < m; x++) {
			result.append(to_string(matCpy[y][x]));
			result.append(" ");
		}
		result.append("\n");
	}
	cout << result;
	return 0;
}