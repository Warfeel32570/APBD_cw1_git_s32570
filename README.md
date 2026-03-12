## Task 5
This merge should create a merge commit.

# 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Fast-forward merge włacza, gdy gałąź docelowa <master> (> git merge dev) nie ma nowych commitów od momentu utworzenia drugiej gałęzi <dev>.
Merge commit wykona się, gdy obie gałęzie (<master> i <dev>) mają nowe commity od momentu rozdzielenia.

# 2. Czym w praktyce różni się merge od rebase?
Merge zachowuje oryginalną historię gałęzi i pokazuje, gdzie nastąpiło ich połączenie. Stosowane jest jeżeli potszebujemy pełny pszebieg pracy.
Rebase upraszcza historię i tworzy liniowy przebieg commitów, ale przepisuje historię. Dzięki temu historja jest uporządkowana, a merge commitów - unikamy :3 Dla pełnej historii urzyłam merge.

# 3. 