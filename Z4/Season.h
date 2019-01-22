#ifndef SEASON_H
#define SEASON_H
#include"Episode.h"
#include<vector>
class Season {
	vector<Episode> mEpisodes;
public:
	Season(Episode**, const int);
	Season(const Season&);
	Season(const vector<Episode>&);
	const vector<Episode>& getEpisodes()const;
	float getAverageRating()const;
	int getTotalViews()const;
	const Episode& getBestEpisode()const;
	void add(const Episode&);
	void remove(const string&);
	Season& operator=(const Season&);
	Episode& operator[](int);
	const Episode& operator[](int)const;
};

const vector<Episode> loadEpisodesFromFile(const string&);

class EpisodeNotFoundException :public runtime_error {
	string mName;
public:
	EpisodeNotFoundException(const string&);
	const string& getName()const;
};
#endif
