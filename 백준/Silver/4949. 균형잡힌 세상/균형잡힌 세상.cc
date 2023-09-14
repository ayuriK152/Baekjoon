#include <iostream>
#include <string>
using namespace std;

int main()
{
	char queue[101];
	string result;
	while (true) {
		string input;
		while (true) {
			string temp;
			getline(cin, temp);
			input.append(temp);
			if (input[input.size() - 1] == '.')
				break;
		}
		if (input.size() == 1 && input[0] == '.')
			break;

		int index = 0;
		bool isComplete = true;
		for (int i = 0; i < input.size(); i++) {
			if (input[i] == '(' || input[i] == '[')
				queue[index++] = input[i];
			else if (input[i] == ')') {
				if (index == 0) {
					isComplete = false;
					break;
				}
				else if (queue[index - 1] != '(') {
					isComplete = false;
					break;
				}
				index--;
			}
			else if (input[i] == ']') {
				if (index == 0) {
					isComplete = false;
					break;
				}
				else if (queue[index - 1] != '[') {
					isComplete = false;
					break;
				}
				index--;
			}
		}

		if (isComplete && index == 0)
			result.append("yes\n");
		else
			result.append("no\n");
	}

	cout << result;
}