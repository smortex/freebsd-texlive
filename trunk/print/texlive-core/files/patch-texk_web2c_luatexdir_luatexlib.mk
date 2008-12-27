
$FreeBSD$

--- texk/web2c/luatexdir/luatexlib.mk.orig
+++ texk/web2c/luatexdir/luatexlib.mk
@@ -42,14 +42,14 @@
 
 
 $(LIBLUADEP):
-	mkdir -p $(LIBLUADIR) && cd $(LIBLUADIR) && cp -f $(LIBLUASRCDIR)/* . && $(MAKE) $(luatarget)
+	cd $(LIBLUASRCDIR) && $(MAKE) $(luatarget)
 
 # slnunicode
 SLNUNICODEDIR=../../libs/slnunicode
 SLNUNICODESRCDIR=$(srcdir)/$(SLNUNICODEDIR)
 SLNUNICODEDEP=$(SLNUNICODEDIR)/slnunico.o
 $(SLNUNICODEDEP): $(SLNUNICODEDIR)/slnunico.c $(SLNUNICODEDIR)/slnudata.c
-	mkdir -p $(SLNUNICODEDIR) && cd $(SLNUNICODEDIR) && cp -f $(SLNUNICODESRCDIR)/* . && $(CC) $(CFLAGS) -I$(LIBLUADIR) -o slnunico.o -c slnunico.c
+	cd $(SLNUNICODESRCDIR) && $(CC) $(CFLAGS) -I$(LIBLUADIR) -o slnunico.o -c slnunico.c
 
 # zziplib
 
@@ -74,11 +74,10 @@
 
 ZZIPLIBDIR=../../libs/zziplib
 ZZIPLIBSRCDIR=$(srcdir)/$(ZZIPLIBDIR)
-ZZIPLIBDEP = $(ZZIPLIBDIR)/zzip/libzzip.a
+ZZIPLIBDEP = ${ZZIPLIBSRCDIR}/`uname -msr | tr " /" "__"`.d/zzip/.libs/libzzip.a
 
 $(ZZIPLIBDEP): $(ZZIPLIBSRCDIR)
-	mkdir -p $(ZZIPLIBDIR)/zzip && cd $(ZZIPLIBDIR)/zzip && \
-	cp ../$(ZZIPLIBSRCDIR)/zzip/Makefile . && $(MAKE) $(common_makeargs)
+	cd $(ZZIPLIBSRCDIR) && $(MAKE) $(common_makeargs)
 
 # luazip
 
@@ -88,8 +87,7 @@
 LUAZIPINC=-I../../lua51 -I../$(ZZIPLIBSRCDIR) -I../$(ZZIPLIBDIR)
 
 $(LUAZIPDEP): $(LUAZIPDIR)/src/luazip.c
-	mkdir -p $(LUAZIPDIR) && cd $(LUAZIPDIR) && cp -R $(LUAZIPSRCDIR)/* . && \
-    cd src && $(CC) $(CFLAGS) $(LUAZIPINC) -g -o luazip.o -c luazip.c
+	cd $(LUAZIPSRCDIR)/src && $(CC) $(CFLAGS) $(LUAZIPINC) -g -o luazip.o -c luazip.c
 
 # luafilesystem
 
@@ -99,15 +97,14 @@
 LUAFSINC=-I../../lua51
 
 $(LUAFSDEP): $(LUAFSDIR)/src/lfs.c $(LUAFSDIR)/src/lfs.h
-	mkdir -p $(LUAFSDIR) && cd $(LUAFSDIR) && cp -R $(LUAFSSRCDIR)/* . && \
-    cd src && $(CC) $(CFLAGS) $(LUAFSINC) -g -o lfs.o -c lfs.c
+	cd $(LUAFSSRCDIR)/src && $(CC) $(CFLAGS) $(LUAFSINC) -g -o lfs.o -c lfs.c
 
 # luapeg
 LUAPEGDIR=../../libs/luapeg
 LUAPEGSRCDIR=$(srcdir)/$(LUAPEGDIR)
 LUAPEGDEP=$(LUAPEGDIR)/lpeg.o
 $(LUAPEGDEP): $(LUAPEGDIR)/lpeg.c
-	mkdir -p $(LUAPEGDIR) && cd $(LUAPEGDIR) && cp -f $(LUAPEGSRCDIR)/* . && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o lpeg.o -c lpeg.c
+	cd $(LUAPEGSRCDIR) && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o lpeg.o -c lpeg.c
 
 
 # luamd5
@@ -115,7 +112,7 @@
 LUAMDVSRCDIR=$(srcdir)/$(LUAMDVDIR)
 LUAMDVDEP=$(LUAMDVDIR)/md5lib.o $(LUAMDVDIR)/md5.o
 $(LUAMDVDEP): $(LUAMDVDIR)/md5lib.c $(LUAMDVDIR)/md5.h $(LUAMDVDIR)/md5.c
-	mkdir -p $(LUAMDVDIR) && cd $(LUAMDVDIR) && cp -f $(LUAMDVSRCDIR)/* . && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o md5.o -c md5.c && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o md5lib.o -c md5lib.c
+	cd $(LUAMDVSRCDIR) && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o md5.o -c md5.c && $(CC) $(CFLAGS) -I$(LIBLUADIR) -g -o md5lib.o -c md5lib.c
 
 .PHONY: always
 
@@ -124,10 +121,7 @@
 LUAFFSRCDIR=$(srcdir)/$(LUAFFDIR)
 LUAFFDEP=$(LUAFFDIR)/libff.a
 $(LUAFFDEP): always
-	mkdir -p $(LUAFFDIR) && cp -f $(LUAFFSRCDIR)/Makefile $(LUAFFDIR)
-	mkdir -p $(LUAFFDIR)/fontforge && cp -f $(LUAFFSRCDIR)/fontforge/fontforge/Makefile $(LUAFFDIR)/fontforge
-	mkdir -p $(LUAFFDIR)/Unicode && cp -f $(LUAFFSRCDIR)/fontforge/Unicode/Makefile $(LUAFFDIR)/Unicode
-	cd $(LUAFFDIR) && $(MAKE)
+	cd $(LUAFFSRCDIR) && $(MAKE)
 
 
 # luazlib
@@ -136,7 +130,7 @@
 LUAZLIBDEP=$(LUAZLIBDIR)/lgzip.o $(LUAZLIBDIR)/lzlib.o
 LUAZLIBINC=-I$(ZLIBSRCDIR) -I$(LIBLUASRCDIR)
 $(LUAZLIBDEP): $(LUAZLIBDIR)/lgzip.c $(LUAZLIBDIR)/lzlib.c
-	mkdir -p $(LUAZLIBDIR) && cd $(LUAZLIBDIR) && cp -f $(LUAZLIBSRCDIR)/* . && $(CC) $(CFLAGS) $(LUAZLIBINC) -g -o lgzip.o -c lgzip.c && $(CC) $(CFLAGS) $(LUAZLIBINC) -g -o lzlib.o -c lzlib.c
+	cd $(LUAZLIBSRCDIR) && $(CC) $(CFLAGS) $(LUAZLIBINC) -g -o lgzip.o -c lgzip.c && $(CC) $(CFLAGS) $(LUAZLIBINC) -g -o lzlib.o -c lzlib.c
 
 
 # Convenience variables.
