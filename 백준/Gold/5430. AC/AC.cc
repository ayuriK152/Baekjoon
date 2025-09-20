#include <iostream>
#include <sstream>
using namespace std;

int main() {
	string answer;

	int t;
	cin >> t;

	for (; t > 0; t--) {
		int arr[100000];
		int n;
		string cmd, arrInput;
		cin >> cmd >> n >> arrInput;
		arrInput.erase(arrInput.begin());
		arrInput.erase(arrInput.end() - 1);

		int elementCount = 0, temp = 0;
		for (int i = 0; i < arrInput.size(); i++) {
			if (arrInput[i] == ',') {
				arr[elementCount++] = temp;
				temp = 0;
			}
			else {
				temp *= 10;
				temp += arrInput[i] - '0';
			}
		}
		arr[elementCount] = temp;

		int left = 0, right = n - 1, count = n;
		bool isFlip = false;
		for (int i = 0; i < cmd.size(); i++) {
			if (cmd[i] == 'R') {
				isFlip = !isFlip;
			}
			else if (cmd[i] == 'D') {
				if (count-- == 0)
					break;
				if (!isFlip)
					left++;
				else
					right--;
			}
		}
		string tempResult;
		if (count < 0)
			tempResult = "error\n";
		else {
			tempResult = "[";
			if (count > 0) {
				if (!isFlip)
					for (int i = left; i <= right; i++)
						tempResult.append(to_string(arr[i]) + ",");
				else
					for (int i = right; i >= left; i--)
						tempResult.append(to_string(arr[i]) + ",");
				tempResult.erase(tempResult.end() - 1);
			}
			tempResult.append("]\n");
		}

		answer.append(tempResult);
	}

	answer.erase(answer.end() - 1);
	cout << answer;

	return 0;
}