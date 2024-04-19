#include <iostream>

using namespace std;

void JudgeBody(int cnt, int cards[], int remainCards[], bool isHeadFixed);

bool requireCards[9];

int main() {
	int cards[9];
	int remainCards[9];
	for (int i = 0; i < 9; i++) {
		cards[i] = 0;
		remainCards[i] = 4;
		requireCards[i] = false;
	}

	for (int i = 0; i < 13; i++) {
		int temp;
		cin >> temp;
		cards[temp - 1]++;
		remainCards[temp - 1]--;
	}

	JudgeBody(0, cards, remainCards, false);

	int headCnt = 0;
	for (int i = 0; i < 9; i++) {
		if (cards[i] == 0)
			continue;
		if (cards[i] >= 2) {
			cards[i] -= 2;
			JudgeBody(0, cards, remainCards, true);
			cards[i] += 2;
			if (cards[i] == 2)
				headCnt++;
		}
	}

	if (headCnt == 6) {
		for (int i = 0; i < 9; i++) {
			if (cards[i] == 1)
				requireCards[i] = true;
		}
	}

	int falseCnt = 0;
	for (int i = 0; i < 9; i++) {
		if (requireCards[i])
			cout << i + 1 << " ";
		else
			falseCnt++;
	}
	if (falseCnt == 9)
		cout << "-1";

	return 0;
}

void JudgeBody(int cnt, int cards[], int remainCards[], bool isHeadFixed)
{
	if (cnt == 3 && isHeadFixed) {
		for (int i = 0; i < 9; i++) {
			if (cards[i] > 0) {
				if (i < 8) {
					if (cards[i] > 0 && cards[i + 1] > 0) {
						if (i < 7 && remainCards[i + 2] > 0)
							requireCards[i + 2] = true;
						if (i > 0 && remainCards[i - 1] > 0)
							requireCards[i - 1] = true;
					}
					else if (cards[i] > 0 && cards[i + 2] > 0 && remainCards[i + 1] > 0) {
						requireCards[i + 1] = true;
					}
				}
				if (cards[i] == 2 && remainCards[i] > 0) {
					requireCards[i] = true;
				}
			}
		}
	}

	else if (cnt == 4) {
		for (int i = 0; i < 9; i++) {
			if (cards[i] > 0 && remainCards[i] > 0)
				requireCards[i] = true;
		}
	}

	else {
		for (int i = 0; i < 9; i++) {
			if (cards[i] > 0) {
				if (i < 7) {
					if (cards[i] > 0 && cards[i + 1] > 0 && cards[i + 2] > 0) {
						cards[i] -= 1;
						cards[i + 1] -= 1;
						cards[i + 2] -= 1;
						JudgeBody(cnt + 1, cards, remainCards, isHeadFixed);
						cards[i] += 1;
						cards[i + 1] += 1;
						cards[i + 2] += 1;
					}
				}
				if (cards[i] >= 3) {
					cards[i] -= 3;
					JudgeBody(cnt + 1, cards, remainCards, isHeadFixed);
					cards[i] += 3;
				}
			}
		}
	}
}