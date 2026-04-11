export interface GenreTheme {
  accent: string;
  accentDeep: string;
  soft: string;
  border: string;
}

const genreHueMap: Record<string, number> = {
  "school books": 206,
  fiction: 226,
  fantasy: 270,
  mystery: 8,
  romance: 336,
  history: 28,
  science: 192,
  philosophy: 42,
  poetry: 292,
  biography: 146,
  adventure: 204,
  thriller: 358
};

export const createGenreTheme = (rawGenre: string): GenreTheme => {
  const normalizedGenre = rawGenre.trim().toLowerCase();
  const mappedHue = genreHueMap[normalizedGenre];

  const hashBasedHue = normalizedGenre
    .split("")
    .reduce((accumulator, letter) => accumulator + letter.charCodeAt(0), 0) % 360;

  const hue = mappedHue ?? hashBasedHue;

  return {
    accent: `hsl(${hue} 78% 46%)`,
    accentDeep: `hsl(${hue} 73% 36%)`,
    soft: `hsl(${hue} 82% 95%)`,
    border: `hsl(${hue} 58% 83%)`,
  };
};
