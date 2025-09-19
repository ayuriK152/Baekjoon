#include <iostream>
#include <string>
using namespace std;

int main() {
	string result;
	int arr[100000];
	int count = 0;
	int n;
	cin >> n;
	for (; n > 0; n--) {
		int input;
		cin >> input;

		switch (input) {
		case 0: {
			if (count == 0) {
				result.append("0\n");
				break;
			}
			else {
				result.append(to_string(arr[0]) + "\n");
				arr[0] = arr[count - 1];
				count--;

				int index = 0;
				while (index != count - 1) {
					int left = (index + 1) * 2 - 1;
					int right = (index + 1) * 2;

					if (right < count) {
						int target = arr[left] > arr[right] ? left : right;
						if (arr[index] < arr[target]) {
							int temp = arr[index];
							arr[index] = arr[target];
							arr[target] = temp;
							index = target;
							continue;
						}
					}
					else if (left < count) {
						if (arr[index] < arr[left]) {
							int temp = arr[index];
							arr[index] = arr[left];
							arr[left] = temp;
							index = left;
							continue;
						}
					}
					break;
				}
			}
			break;
		}

		default: {
			int index = count++;
			arr[index] = input;

			while (index != 0) {
				int parent = (index + 1) / 2 - 1;
				if (arr[index] > arr[parent]) {
					int temp = arr[index];
					arr[index] = arr[parent];
					arr[parent] = temp;
					index = parent;
					continue;
				}
				break;
			}

			break;
		}
		}
	}
	result.erase(result.end() - 1);

	cout << result;

	return 0;
}