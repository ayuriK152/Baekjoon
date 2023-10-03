#include <iostream>
using namespace std;

int main() {
	bool matA[50][50] = { false };
	bool matB[50][50] = { false };
	int n, m;
	cin >> n >> m;
	int result = 0;

	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		for (int j = 0; j < m; j++)
			matA[i][j] = input[j] == '1' ? true : false;
	}

	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		for (int j = 0; j < m; j++)
			matB[i][j] = input[j] == '1' ? true : false;
	}

	if (n < 3 || m < 3) {
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (matA[i][j] != matB[i][j])
					result = -1;
			}
		}
	}
	else {
		for (int i = 0; i < n - 2; i++) {
			for (int j = 0; j < m - 2; j++) {
				if (matA[i][j] != matB[i][j]) {
					for (int y = i; y < i + 3; y++)
						for (int x = j; x < j + 3; x++)
							matA[y][x] = !matA[y][x];
					result++;
				}
			}
		}

		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (matA[i][j] != matB[i][j])
					result = -1;
			}
		}
	}

	cout << result;
	return 0;
}