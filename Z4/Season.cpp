#include"Season.h"
#include<fstream>
Season::Season(Episode** eps, const int count) {
	for (int i = 0; i < count; i++)
		mEpisodes.push_back(Episode(*eps[i]));
}
Season::Season(const Season& s) : mEpisodes(s.mEpisodes) {}
Season::Season(const vector<Episode>& eps):mEpisodes(eps) {}
const vector<Episode>& Season::getEpisodes()const {
	return mEpisodes;
}
float Season::getAverageRating()const {
	float sum = 0;
	for (int i = 0; i < mEpisodes.size(); i++)
		sum += mEpisodes[i].getAverageScore();
	return sum / mEpisodes.size();
}
int Season::getTotalViews()const {
	int sum = 0;
	for (int i = 0; i < mEpisodes.size(); i++)
		sum += mEpisodes[i].getViewerCount();
	return sum;
}
const Episode& Season::getBestEpisode()const {
	float bestMaxScore = mEpisodes[0].getMaxScore();
	int indexOfBestEpisode = 0;
	for (int i = 1; i<mEpisodes.size(); i++)
		if (mEpisodes[i].getMaxScore() > bestMaxScore) {
			bestMaxScore = mEpisodes[i].getMaxScore();
			indexOfBestEpisode = i;
		}
	return mEpisodes[indexOfBestEpisode];
}
void Season::add(const Episode& ep) {
	mEpisodes.push_back(ep);
}
void Season::remove(const string& name) {
	bool found = false;
	for (int i = 0; i < mEpisodes.size(); i++)
		if (name == mEpisodes[i].getDescription().getName()) {
			mEpisodes.erase(mEpisodes.begin()+i);
			found = true;
			break;
		}
	if (!found)throw(EpisodeNotFoundException(name));
}
Season& Season::operator=(const Season& s) {
	if (&s == this)return *this;
	mEpisodes = s.mEpisodes;
	return *this;
}
const Episode& Season::operator[](int index)const {
	return mEpisodes[index];
}
Episode& Season::operator[](int index) {
	return mEpisodes[index];
}

const vector<Episode> loadEpisodesFromFile(const string& filename) {
	vector<Episode> episodes;
	ifstream input(filename);
	if (!input.is_open())
		return episodes;
	int count = 0;
	while (!input.eof()) {
		episodes.push_back(Episode());
		input >> episodes[count++];
	}
	input.close();
	return episodes;
}

EpisodeNotFoundException::EpisodeNotFoundException(const string& name):mName(name),runtime_error("No such episode found."){}
const string& EpisodeNotFoundException::getName()const {
	return mName;
}
