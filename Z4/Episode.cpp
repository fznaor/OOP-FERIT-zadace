#include<fstream>
#include"Episode.h"
Episode::Episode() :mViewers(0), mTotalScore(0), mMaxScore(0), mDescription(Description()) {}
Episode::Episode(int viewers, float totalScore, float maxScore, const Description& dscrptn) : mViewers(viewers), mTotalScore(totalScore), mMaxScore(maxScore), mDescription(dscrptn) {}
void Episode::addView(float score) {
	mViewers++;
	mTotalScore += score;
	if (score > mMaxScore)	mMaxScore = score;
}
int Episode::getViewerCount()const {
	return mViewers;
}
float Episode::getAverageScore()const {
	return mTotalScore / mViewers;
}
float Episode::getMaxScore()const {
	return mMaxScore;
}
const Description& Episode::getDescription()const {
	return mDescription;
}
ostream& operator<<(ostream& out, const Episode& ep) {
	out << ep.mViewers << " ," << ep.mTotalScore << "," << ep.mMaxScore << "," << ep.mDescription;
	return out;
}
istream& operator>>(istream& in, Episode& ep) {
	char ignoreComma;
	in >> ep.mViewers >> ignoreComma >> ep.mTotalScore >> ignoreComma >> ep.mMaxScore >> ep.mDescription;
	return in;
}
bool operator==(const Episode& lhs, const Episode& rhs) {
	return lhs.mViewers == rhs.mViewers && lhs.mTotalScore == rhs.mTotalScore && lhs.mMaxScore == rhs.mMaxScore && lhs.getDescription().getNumber() == rhs.getDescription().getNumber()
		&& lhs.getDescription().getLength() == rhs.getDescription().getLength() && lhs.getDescription().getName() == rhs.getDescription().getName();
}
bool operator!=(const Episode& lhs, const Episode& rhs) {
	return !operator==(lhs, rhs);
}
bool operator<(const Episode& lhs, const Episode& rhs) {
	return lhs.getDescription().getName()[0] < rhs.getDescription().getName()[0];
}
bool operator>(const Episode& lhs, const Episode& rhs) {
	return operator<(rhs, lhs);
}
bool operator>=(const Episode& lhs, const Episode& rhs) {
	return !operator<(lhs, rhs);
}
bool operator<=(const Episode& lhs, const Episode& rhs) {
	return !operator>(lhs, rhs);
}

float generateRandomScore() {
	return static_cast<float>(std::rand()) / RAND_MAX * 10;
}
void print(Episode** eps, const int count) {
	for (int i = 0; i < count; i++)
		cout << i << ". " << *eps[i] << endl;
}
void swap(Episode** ep1, Episode** ep2) {
	Episode *temp;
	temp = *ep1;
	*ep1 = *ep2;
	*ep2 = temp;
}
void sort(Episode** eps, const int count) {
	for (int i = 0; i < count - 1; i++)
		for (int j = 0; j < count - 1 - i; j++)
			if (*eps[j] > *eps[j + 1])
				swap(&eps[j], &eps[j + 1]);
}
void persistToFile(const string& filename, Episode** eps, const int count) {
	ofstream file(filename);
	if (file.is_open() == false)
		return;
	for (int i = 0; i < count; i++)
		file << *eps[i] << endl;
	file.close();
}
