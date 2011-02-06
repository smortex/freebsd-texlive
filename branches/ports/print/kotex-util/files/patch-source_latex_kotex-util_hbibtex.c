
$FreeBSD$

--- source/latex/kotex-util/hbibtex.c.orig
+++ source/latex/kotex-util/hbibtex.c
@@ -14,7 +14,7 @@
 
 int to_8bit(char *);
 
-main(int argc, char *argv[])
+int main(int argc, char *argv[])
 {
   int i;
   char args[128], cmd[128];
