#include <iostream>
using namespace std;

int main() {
	bool depth[500][500] = { false };
	int h, w;
	cin >> h >> w;
	for (int i = 0; i < w; i++) {
		int a;
		cin >> a;
		for (int j = 0; j < a; j++)
			depth[i][j] = true;
	}
	int count = 0;
	for (int i = 0; i < h; i++) {
		int point = -1;
		for (int j = 0; j < w; j++) {
			if (depth[j][i]) {
				if (point != -1)
					count += j - point - 1;
				point = j;
			}
		}
	}

	cout << count;
	return 0;
}