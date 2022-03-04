﻿// Pseudo git - powiązanie wzorca momento z systemem kontroli wersji
var committer = new Committer();
var git = new Git(committer);
committer.StageFiles(new List<string>(){"Test1.txt", "Test2.txt", "Test3.txt"});
git.Commit("3 files to commit");
committer.StageFiles(new List<string>() { "Test4.txt", "Test5.txt" });
git.Commit("2 files to commit");
committer.StageFiles(new List<string>() { "Peugeot.txt", "BMW.txt", "Audi.txt", "Skoda.txt", "Ferrari.txt" });
git.Commit("5 files to commit");
git.ShowHistory();
git.ResetLast();
git.ShowHistory();
git.ResetLast();
git.ShowHistory();