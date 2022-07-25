using Trees;

List<Tree> myTreeColl = new List<Tree>();
var a1 = new Tree { Name = "Osina", Children = myTreeColl };
var a2 = new Tree { Name = "Dub" };
myTreeColl.Add(a2);
List<Tree> myTreeColl2 = new List<Tree>();
var b2 = new Tree { Name = "Topol", Children = myTreeColl2 };
myTreeColl.Add(b2);
var a3 = new Tree { Name = "Yasen" };
var b3 = new Tree { Name = "Bereza" };
myTreeColl2.Add(a3);
myTreeColl2.Add(b3);
a1.WriteAllNamesInATree();

