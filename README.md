<h1>magnaCarta</h1>
###switch branch <br>
git checkout branchname <br>

###merge myBranch into master <br>
//get latest version of master branch<br>
git checkout master <br>
git pull <br>
//merge the branches <br>
git checkout myBranch <br>
git merge master <br>

###//COMMIT changes to local repository<br>
//interactive add <br>
git add -i<br>
//update and add untracked<br>
git commit -m "message<br>
####OR<br>
git commit -a -m "message"<br>

###Review<br>
order:<br>
git commit (save changes to local repo)<br>
git pull (get and auto merge from remote repo)<br>
merge and run again <br>
git push (save local changes to remote repo)<br>
