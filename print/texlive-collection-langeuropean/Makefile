# $FreeBSD$

PORTNAME=	collection-langeuropean
PORTVERSION=	20130514
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Other European languages

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
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-local/black.mf:${PORTSDIR}/print/texlive-knuth-local \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/blackcx.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-albanian/albanian.ldf:${PORTSDIR}/print/texlive-babel-albanian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-breton/breton.ldf:${PORTSDIR}/print/texlive-babel-breton \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-croatian/croatian.ldf:${PORTSDIR}/print/texlive-babel-croatian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-danish/danish.ldf:${PORTSDIR}/print/texlive-babel-danish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-dutch/dutch.ldf:${PORTSDIR}/print/texlive-babel-dutch \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-estonian/estonian.ldf:${PORTSDIR}/print/texlive-babel-estonian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-finnish/finnish.ldf:${PORTSDIR}/print/texlive-babel-finnish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-friulan/friulan.ldf:${PORTSDIR}/print/texlive-babel-friulan \
		${LOCALBASE}/share/texmf-dist/tex/latex/babel-hungarian/magyar.ldf:${PORTSDIR}/print/texlive-babel-hungarian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-icelandic/icelandic.ldf:${PORTSDIR}/print/texlive-babel-icelandic \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-irish/irish.ldf:${PORTSDIR}/print/texlive-babel-irish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-kurmanji/kurmanji.ldf:${PORTSDIR}/print/texlive-babel-kurmanji \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-latin/latin.ldf:${PORTSDIR}/print/texlive-babel-latin \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-norsk/norsk.ldf:${PORTSDIR}/print/texlive-babel-norsk \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-piedmontese/piedmontese.ldf:${PORTSDIR}/print/texlive-babel-piedmontese \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-romanian/romanian.ldf:${PORTSDIR}/print/texlive-babel-romanian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-romansh/romansh.ldf:${PORTSDIR}/print/texlive-babel-romansh \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-samin/samin.ldf:${PORTSDIR}/print/texlive-babel-samin \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-scottish/scottish.ldf:${PORTSDIR}/print/texlive-babel-scottish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-slovenian/slovene.ldf:${PORTSDIR}/print/texlive-babel-slovenian \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-swedish/swedish.ldf:${PORTSDIR}/print/texlive-babel-swedish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-turkish/turkish.ldf:${PORTSDIR}/print/texlive-babel-turkish \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-welsh/welsh.ldf:${PORTSDIR}/print/texlive-babel-welsh \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/finbib/finplain.bst:${PORTSDIR}/print/texlive-finbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/hrlatex/hrlatex.sty:${PORTSDIR}/print/texlive-hrlatex \
		${LOCALBASE}/share/texmf-dist/tex/latex/lithuanian/lithuanian.sty:${PORTSDIR}/print/texlive-lithuanian \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/swebib/sweabbrv.bst:${PORTSDIR}/print/texlive-swebib \
		${LOCALBASE}/share/texmf-dist/tex/latex/turkmen/turkmen.ldf:${PORTSDIR}/print/texlive-turkmen

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
