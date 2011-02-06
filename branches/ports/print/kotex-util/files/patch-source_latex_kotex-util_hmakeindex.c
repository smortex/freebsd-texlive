
$FreeBSD$

--- source/latex/kotex-util/hmakeindex.c.orig
+++ source/latex/kotex-util/hmakeindex.c
@@ -12,10 +12,14 @@
 #define MKSTEMP mkstemp
 #endif
 
+#ifdef __FreeBSD__
+#include <ctype.h>
+#endif
+
 #define BIT(x) (1<<x)
 
 char idx[1024], ind[1024];
-int cho=-1, style_used=0;
+int style_used=0;
 int to_8bit(void);
 int hangul_head(int);
 int doublebyte(int, int);
@@ -23,7 +27,7 @@
 int ucs(int);
 void fputs_item(char *, FILE *);
 
-main(int argc, char *argv[])
+int main(int argc, char *argv[])
 {
   int i, outfile_used=0;
   char prog[1024], args[1024], cmd[128], idx0[1024];
@@ -117,7 +121,7 @@
   }
 
   while(fgets(line, 1024, in)) {
-    l=line;
+    l=(unsigned char *)line;
     while(*l) {
       if(*l=='^'&&*(l+1)=='^'
 	 &&(h1=strchr(HEXA_STRING, *(l+2)))
@@ -134,10 +138,10 @@
 	w=x;
       }
       else {
-	if(w>127 && *l>127) {
+	if(w>127 && ((unsigned char) *l)>127) {
 	  /* 이미 변환된 .idx 파일의 경우 */
 	  hangul_enc=1;
-	  if(w<161 || *l<161) utf_seen=1;
+	  if(w<161 || ((unsigned char)*l)<161) utf_seen=1;
 	}
 	w=*l;
 	/* 위치 표시 문자 '@'는 '\a'으로 변환하여 makeindex로 처리한 후
@@ -157,11 +161,11 @@
   return(hangul_enc+utf_seen);
 }
 
-int hangul_head(encoding) {
+int hangul_head(int encoding) {
   FILE *in, *out;
   char tempfile[9];
-  unsigned char line[1024], *l;
-  unsigned int cho=20, x;
+  char line[1024], *l;
+  int cho=20, x;
 
   strcpy(tempfile, "INDXXXXXX");
   MKSTEMP(tempfile);
@@ -174,7 +178,7 @@
     if(strncmp(l, "\\item", 5)==0) {
       l+=5;
       while(isspace(*l)) l++;
-      if(*l<128) {
+      if(((unsigned char)*l)<128) {
 	fputs_item(line, out);
 	continue;
       }
@@ -199,7 +203,7 @@
     else if(strncmp(l, "\\indexspace", 11)==0) {
       if(cho<0 || cho>19) fputs(line, out);
     }
-    else if(!(strncmp(l, "\\indexhead{", 11)==0&&*(l+11)>128)) {
+    else if(!(strncmp(l, "\\indexhead{", 11)==0&&*((unsigned char *)(l+11))>128)) {
       fputs(line, out);
     }
   }
