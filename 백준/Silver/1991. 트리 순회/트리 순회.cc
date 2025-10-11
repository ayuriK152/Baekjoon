#include <bits/stdc++.h>
using namespace std;

map<char, pair<char, char>> tree;
string pre, in, post;

void Recursive(char node) {
	pre += node;
	if (tree[node].first != '.') {
		Recursive(tree[node].first);
	}
	in += node;
	if (tree[node].second != '.') {
		Recursive(tree[node].second);
	}
	post += node;
}

int main() {
	pre = ""; in = ""; post = "";

	int n;
	cin >> n;
	
	for (int i = 0; i < n; i++) {
		char root, l, r;
		cin >> root >> l >> r;
		tree[root] = { l ,r };
	}

	Recursive('A');

	cout << pre << "\n" << in << "\n" << post;

	return 0;
}