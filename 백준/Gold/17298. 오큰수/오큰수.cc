#include <iostream>
#include <string>
#include <cstring>
#include <stack>
using namespace std;

int main() {
	string answer;

	int arr[1000000];
	int nge[1000000];
	int n;
	cin >> n;
	memset(nge, -1, sizeof(int) * 1000000);

	for (int i = 0; i < n; i++) {
		cin >> arr[i];
	}

	stack<int> s;
	for (int i = 0; i < n; i++) {
		while (!s.empty()) {
			if (arr[i] > arr[s.top()]) {
				nge[s.top()] = arr[i];
				s.pop();
			}
			else
				break;
		}
		s.push(i);
	}

	for (int i = 0; i < n; i++) {
		if (nge[i] == -1)
			answer.append(to_string(-1) + " ");
		else
			answer.append(to_string(nge[i]) + " ");
	}

	answer.erase(answer.end() - 1);
	cout << answer;

	return 0;
}