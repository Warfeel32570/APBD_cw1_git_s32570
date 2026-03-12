## Task 5
This merge should create a merge commit.

## Task 6
I'm here for you just to see how rebase works.

## Task 7
main: Console.WriteLine("yyy");
feature-conflict: Console.WriteLine("xxx");
Pszy próbie merge <main> i <feature-conflict> auto-merge nie działa --> naprawa kodu i ponowna próba.

# 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
Fast-forward merge włacza, gdy gałąź docelowa <master> (> git merge dev) nie ma nowych commitów od momentu utworzenia drugiej gałęzi <dev>.
Merge commit wykona się, gdy obie gałęzie (<master> i <dev>) mają nowe commity od momentu rozdzielenia.

# 2. Czym w praktyce różni się merge od rebase?
Merge zachowuje oryginalną historię gałęzi i pokazuje, gdzie nastąpiło ich połączenie. Stosowane jest jeżeli potszebujemy pełny pszebieg pracy.
Rebase upraszcza historię i tworzy liniowy przebieg commitów, ale przepisuje historię. Dzięki temu historja jest uporządkowana, a merge commitów - unikamy :3 Dla pełnej historii urzyłam merge.

# 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
W moim repozytorium conflict zostal rozwiązany za pomocą aktualizacji kodu w main i feature-conflict, tak aby było to samo.