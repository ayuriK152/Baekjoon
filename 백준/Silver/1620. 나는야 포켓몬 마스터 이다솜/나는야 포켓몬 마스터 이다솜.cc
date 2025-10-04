#include <bits/stdc++.h>
#include <unordered_map>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(NULL);

	unordered_map<int, string> idName;
	unordered_map<string, int> nameId;
	string answer;

	int n, m;
	cin >> n >> m;

	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		idName[i + 1] = input;
		nameId[input] = i + 1;
	}

	for (int i = 0; i < m; i++) {
		string input;
		cin >> input;
		if (input[0] >= '0' && input[0] <= '9')
			answer.append(idName[stoi(input)] + "\n");
		else
			answer.append(to_string(nameId[input]) + "\n");
	}

	printf(answer.c_str());

	return 0;
}