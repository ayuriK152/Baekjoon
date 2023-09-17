#include <iostream>
#include <string>
#include <vector>
using namespace std;

int main() {
	int n;
	cin >> n;
	int arr[500000];
	vector<int> stack;
	int index = 0;
	string result = "";
	for (int i = 0; i < n; i++) {
		cin >> arr[i];
		while (!stack.empty() && arr[stack.back()] < arr[i])
			stack.pop_back();
		if (!stack.empty())
			result.append(to_string(stack.back() + 1) + " ");
		else
			result.append("0 ");
		stack.push_back(i);
	}
	cout << result;
	return 0;
}