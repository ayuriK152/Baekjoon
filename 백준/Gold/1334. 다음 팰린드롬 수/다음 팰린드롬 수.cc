#include <bits/stdc++.h>
using namespace std;

void NumStringAddition(string& numStr, int index) {
	for (int i = index; i >= 0; i--) {
		if (numStr[i] == '9')
			numStr[i] = '0';
		else {
			numStr[i] += 1;
			break;
		}
	}

	if (numStr[0] == '0')
		numStr = '1' + numStr;
}

int main() {
	string numStr;
	cin >> numStr;
	NumStringAddition(numStr, numStr.size() - 1);

	if (numStr.size() > 1) {
		while (true) {
			int left, right;

			if (numStr.size() % 2 == 0) {
				left = numStr.size() / 2 - 1;
				right = left + 1;
			}
			else {
				left = numStr.size() / 2 - 1;
				right = left + 2;
			}

			bool flag = false;
			while (true) {
				if (numStr[left] > numStr[right]) {
					numStr[right] = numStr[left];
					for (int i = right + 1; i < numStr.size(); i++)
						numStr[i] = '0';
				}
				if (numStr[left] < numStr[right]) {
					for (int i = right; i < numStr.size(); i++)
						numStr[i] = '0';
					NumStringAddition(numStr, right - 1);
					break;
				}
				if (left == 0) {
					flag = true;
					break;
				}
				left--;
				right++;
			}

			if (flag)
				break;
		}
	}

	cout << numStr;
	return 0;
}