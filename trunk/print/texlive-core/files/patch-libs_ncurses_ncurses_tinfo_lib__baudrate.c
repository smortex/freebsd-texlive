
$FreeBSD$

--- libs/ncurses/ncurses/tinfo/lib_baudrate.c.orig
+++ libs/ncurses/ncurses/tinfo/lib_baudrate.c
@@ -46,7 +46,10 @@
  * of the indices up to B115200 fit nicely in a 'short', allowing us to retain
  * ospeed's type for compatibility.
  */
-#if defined(__FreeBSD__) || defined(__NetBSD__) || defined(__OpenBSD__)
+#if defined(__FreeBSD__)
+# include <osreldate.h>
+#endif /* defined(__FreeBSD__) */
+#if (defined(__FreeBSD__) && (__FreeBSD_version < 800039)) || defined(__NetBSD__) || defined(__OpenBSD__)
 #undef B0
 #undef B50
 #undef B75
