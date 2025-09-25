#include <bits/stdc++.h>
using namespace std;

struct Node {
	int parent;
	vector<int> childs;
	int childCount = 0;
	bool isDelete = false;

	Node(int _parent) : parent(_parent) {}
};

int main() {
	vector<Node> tree;
	int n;
	cin >> n;
	for (int i = 0; i < n; i++)
		tree.push_back(Node(-1));
	for (int i = 0; i < n; i++) {
		int p;
		cin >> p;
		tree[i].parent = p;
		if (p != -1)
			tree[p].childs.push_back(i);
	}
	for (Node& node : tree)
		node.childCount = node.childs.size();

	int d;
	cin >> d;
	queue<int> q;
	q.push(d);
	if (tree[d].parent != -1)
		tree[tree[d].parent].childCount--;

	while (!q.empty()) {
		int curr = q.front();
		q.pop();
		tree[curr].isDelete = true;
		for (int c : tree[curr].childs)
			q.push(c);
	}

	int count = 0;
	for (Node node : tree) {
		if (node.isDelete || node.childCount > 0)
			continue;
		count++;
	}

	cout << count;

	return 0;
}