# $FreeBSD$

PORTNAME=	collection-xetex
PORTVERSION=	20150901
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	XeTeX and packages

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/dvips/base/color.pro:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
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
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/arabxetex/arabxetex.sty:${PORTSDIR}/print/texlive-arabxetex \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/bidi-atbegshi/bidi-atbegshi.sty:${PORTSDIR}/print/texlive-bidi-atbegshi \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/bidicontour/bidicontour.sty:${PORTSDIR}/print/texlive-bidicontour \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/bidipagegrid/bidipagegrid.sty:${PORTSDIR}/print/texlive-bidipagegrid \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/bidishadowtext/bidishadowtext.sty:${PORTSDIR}/print/texlive-bidishadowtext \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/bidipresentation/bidipresentation.cls:${PORTSDIR}/print/texlive-bidipresentation \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/fixlatvian/fixlatvian.sty:${PORTSDIR}/print/texlive-fixlatvian \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/fontbook/fontbook.sty:${PORTSDIR}/print/texlive-fontbook \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/fontwrap/fontwrap.sty:${PORTSDIR}/print/texlive-fontwrap \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/interchar/interchar.sty:${PORTSDIR}/print/texlive-interchar \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/mathspec/mathspec.sty:${PORTSDIR}/print/texlive-mathspec \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/philokalia/philokalia.sty:${PORTSDIR}/print/texlive-philokalia \
		${LOCALBASE}/share/texmf-dist/tex/latex/polyglossia/polyglossia.sty:${PORTSDIR}/print/texlive-polyglossia \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/ptext/ptext.sty:${PORTSDIR}/print/texlive-ptext \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/quran/quran.sty:${PORTSDIR}/print/texlive-quran \
		${LOCALBASE}/share/texmf-dist/tex/latex/realscripts/realscripts.sty:${PORTSDIR}/print/texlive-realscripts \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/ucharclasses/ucharclasses.sty:${PORTSDIR}/print/texlive-ucharclasses \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/unisugar/unisugar.sty:${PORTSDIR}/print/texlive-unisugar \
		${LOCALBASE}/share/texmf-dist/tex/latex/xebaposter/xebaposter.cls:${PORTSDIR}/print/texlive-xebaposter \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/xecjk/full-stop.map:${PORTSDIR}/print/texlive-xecjk \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xecolor/xecolor.sty:${PORTSDIR}/print/texlive-xecolor \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xecyr/xecyr.sty:${PORTSDIR}/print/texlive-xecyr \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xeindex/xeindex.sty:${PORTSDIR}/print/texlive-xeindex \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xepersian/xepersian.sty:${PORTSDIR}/print/texlive-xepersian \
		${LOCALBASE}/share/texmf-dist/tex/xetex/xesearch/xesearch.sty:${PORTSDIR}/print/texlive-xesearch \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xespotcolor/xespotcolor.sty:${PORTSDIR}/print/texlive-xespotcolor \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/base/qx-unicode.map:${PORTSDIR}/print/texlive-xetex \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xetex-def/xetex.def:${PORTSDIR}/print/texlive-xetex-def \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/xetex-itrans/brh-kan.map:${PORTSDIR}/print/texlive-xetex-itrans \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xetex-pstricks/pstricks.con:${PORTSDIR}/print/texlive-xetex-pstricks \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/xetex-tibetan/loctib.map:${PORTSDIR}/print/texlive-xetex-tibetan \
		${LOCALBASE}/share/texmf-dist/tex/generic/xetexconfig/unicode-letters.tex:${PORTSDIR}/print/texlive-xetexconfig \
		${LOCALBASE}/share/texmf-dist/tex/xetex/xetexfontinfo/aat-info.tex:${PORTSDIR}/print/texlive-xetexfontinfo \
		${LOCALBASE}/share/texmf-dist/tex/xetex/xetexko/xetexko.sty:${PORTSDIR}/print/texlive-xetexko \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xevlna/xevlna.sty:${PORTSDIR}/print/texlive-xevlna \
		${LOCALBASE}/share/texmf-dist/tex/latex/xltxtra/xltxtra.sty:${PORTSDIR}/print/texlive-xltxtra \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/xunicode/xunicode.sty:${PORTSDIR}/print/texlive-xunicode

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
