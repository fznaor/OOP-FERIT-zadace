#include<cstdlib>
#include"Header.h"
Episode::Episode() :mViewers(0), mTotalScore(0), mMaxScore(0)
{
}
Episode::Episode(int viewers, float totalScore, float maxScore) :mViewers(viewers), mTotalScore(totalScore), mMaxScore(maxScore)
{
}
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
float generateRandomScore() {
	return static_cast<float>(std::rand()) / RAND_MAX * 10;
}