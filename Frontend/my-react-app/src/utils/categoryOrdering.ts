const isAnotherCategory = (value: string): boolean => {
  const normalized = value.trim().toLowerCase();
  return normalized === "another" || normalized === "anoter" || normalized === "other";
};

export const moveAnotherToEnd = (categoryNames: string[]): string[] => {
  const regularCategories: string[] = [];
  const anotherCategories: string[] = [];

  for (const categoryName of categoryNames) {
    if (isAnotherCategory(categoryName)) {
      anotherCategories.push(categoryName);
    } else {
      regularCategories.push(categoryName);
    }
  }

  return [...regularCategories, ...anotherCategories];
};

export const orderCategoriesForHome = (categoryNames: string[]): string[] => {
  const uniqueNames = Array.from(new Set(categoryNames.map((name) => (name || "").trim()).filter(Boolean)));
  const schoolBooksIndex = uniqueNames.findIndex(
    (name) => name.toLowerCase() === "school books"
  );

  const schoolBooksFirst =
    schoolBooksIndex <= 0
      ? uniqueNames
      : [
          uniqueNames[schoolBooksIndex],
          ...uniqueNames.slice(0, schoolBooksIndex),
          ...uniqueNames.slice(schoolBooksIndex + 1),
        ];

  return moveAnotherToEnd(schoolBooksFirst);
};