#include <bits/stdc++.h>
#include <unordered_map>
using namespace std;

int main() {
	unordered_map<string, bool> map;
	vector<string> answer;
	int n, m;
	cin >> n >> m;
	
	for (int i = 0; i < n; i++) {
		string input;
		cin >> input;
		map[input] = false;
	}

	for (int i = 0; i < m; i++) {
		string input;
		cin >> input;
		if (map.count(input) != 0)
			answer.push_back(input);
	}

	sort(answer.begin(), answer.end());

	printf("%d\n", answer.size());
	for (string s : answer)
		printf("%s\n", s.c_str());

	return 0;
}