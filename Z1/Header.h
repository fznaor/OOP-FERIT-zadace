#ifndef HEADER_H
#define HEADER_H
class Episode {
	int mViewers;
	float mTotalScore;
	float mMaxScore;
public:
	Episode();
	Episode(int, float, float);
	void addView(float);
	int getViewerCount()const;
	float getAverageScore()const;
	float getMaxScore()const;
};
float generateRandomScore();
#endif
