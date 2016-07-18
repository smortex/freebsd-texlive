# $FreeBSD$

PORTNAME=	collection-luatex
PORTVERSION=	20160708
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LuaTeX packages

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/dvips/base/color.pro:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics-def/dvipdfmx.def:${PORTSDIR}/print/texlive-graphics-def \
		${LOCALBASE}/share/texmf-dist/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-local/black.mf:${PORTSDIR}/print/texlive-knuth-local \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/mf.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex-ini-files/dvilualatex.ini:${PORTSDIR}/print/texlive-tex-ini-files \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/tex/generic/unicode-data/CaseFolding.txt:${PORTSDIR}/print/texlive-unicode-data \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/updmap/kanjix.map:${PORTSDIR}/print/texlive-updmap-map \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/scripts/checkcites/checkcites.lua:${PORTSDIR}/print/texlive-checkcites \
		${LOCALBASE}/share/texmf-dist/tex/luatex/chickenize/chickenize.sty:${PORTSDIR}/print/texlive-chickenize \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/cloze/cloze.sty:${PORTSDIR}/print/texlive-cloze \
		${LOCALBASE}/share/texmf-dist/tex/luatex/ctablestack/ctablestack.sty:${PORTSDIR}/print/texlive-ctablestack \
		${LOCALBASE}/share/texmf-dist/tex/latex/enigma/enigma.sty:${PORTSDIR}/print/texlive-enigma \
		${LOCALBASE}/share/texmf-dist/tex/luatex/interpreter/interpreter.sty:${PORTSDIR}/print/texlive-interpreter \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/lua-check-hyphen/lua-check-hyphen.sty:${PORTSDIR}/print/texlive-lua-check-hyphen \
		${LOCALBASE}/share/texmf-dist/tex/luatex/lua-visual-debug/lua-visual-debug.sty:${PORTSDIR}/print/texlive-lua-visual-debug \
		${LOCALBASE}/share/texmf-dist/scripts/lua2dox/lua.def:${PORTSDIR}/print/texlive-lua2dox \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luabibentry/luabibentry.sty:${PORTSDIR}/print/texlive-luabibentry \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luabidi/luabidi.sty:${PORTSDIR}/print/texlive-luabidi \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luacode/luacode.sty:${PORTSDIR}/print/texlive-luacode \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luaindex/luaindex.sty:${PORTSDIR}/print/texlive-luaindex \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luainputenc/luainputenc.sty:${PORTSDIR}/print/texlive-luainputenc \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/lualatex-math/lualatex-math.sty:${PORTSDIR}/print/texlive-lualatex-math \
		${LOCALBASE}/share/texmf-dist/tex/luatex/lualibs/lualibs-basic-merged.lua:${PORTSDIR}/print/texlive-lualibs \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luamplib/luamplib.sty:${PORTSDIR}/print/texlive-luamplib \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luaotfload/luaotfload.sty:${PORTSDIR}/print/texlive-luaotfload \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luasseq/luasseq.sty:${PORTSDIR}/print/texlive-luasseq \
		${LOCALBASE}/share/texmf-dist/tex/generic/luatex85/luatex85.sty:${PORTSDIR}/print/texlive-luatex85 \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luatexbase/luatexbase.sty:${PORTSDIR}/print/texlive-luatexbase \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luatexko/luatexko.sty:${PORTSDIR}/print/texlive-luatexko \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luatextra/luatextra.sty:${PORTSDIR}/print/texlive-luatextra \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/luatodonotes/luatodonotes.sty:${PORTSDIR}/print/texlive-luatodonotes \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luaxml/dom-sample.lua:${PORTSDIR}/print/texlive-luaxml \
		${LOCALBASE}/share/texmf-dist/tex/luatex/nodetree/nodetree.sty:${PORTSDIR}/print/texlive-nodetree \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/odsfile/odsfile.sty:${PORTSDIR}/print/texlive-odsfile \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/placeat/placeat.sty:${PORTSDIR}/print/texlive-placeat \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/selnolig/selnolig.sty:${PORTSDIR}/print/texlive-selnolig \
		${LOCALBASE}/share/texmf-dist/tex/lualatex/showhyphens/showhyphens.sty:${PORTSDIR}/print/texlive-showhyphens \
		${LOCALBASE}/share/texmf-dist/tex/luatex/spelling/spelling.sty:${PORTSDIR}/print/texlive-spelling \
		${LOCALBASE}/share/texmf-dist/tex/latex/ucharcat/ucharcat.sty:${PORTSDIR}/print/texlive-ucharcat

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
