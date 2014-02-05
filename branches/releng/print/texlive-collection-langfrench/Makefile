# $FreeBSD$

PORTNAME=	collection-langfrench
PORTVERSION=	20130510
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	French

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
		${LOCALBASE}/share/texmf-dist/tex/latex/aeguill/aeguill.sty:${PORTSDIR}/print/texlive-aeguill \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-basque/basque.ldf:${PORTSDIR}/print/texlive-babel-basque \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel-french/frenchb.ldf:${PORTSDIR}/print/texlive-babel-french \
		${LOCALBASE}/share/texmf-dist/tex/latex/basque-book/basque-book.cls:${PORTSDIR}/print/texlive-basque-book \
		${LOCALBASE}/share/texmf-dist/tex/latex/basque-date/basque-date.sty:${PORTSDIR}/print/texlive-basque-date \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/bib-fr/abbrv-fr.bst:${PORTSDIR}/print/texlive-bib-fr \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibleref-french/bibleref-french.sty:${PORTSDIR}/print/texlive-bibleref-french \
		${LOCALBASE}/share/texmf-dist/tex/latex/droit-fr/droit-fr.cls:${PORTSDIR}/print/texlive-droit-fr \
		${LOCALBASE}/share/texmf-dist/tex/xelatex/facture/facture.cls:${PORTSDIR}/print/texlive-facture \
		${LOCALBASE}/share/texmf-dist/tex/latex/frenchle/frenchle.sty:${PORTSDIR}/print/texlive-frenchle \
		${LOCALBASE}/share/texmf-dist/tex/latex/frletter/frletter.cls:${PORTSDIR}/print/texlive-frletter \
		${LOCALBASE}/share/texmf-dist/tex/latex/impnattypo/impnattypo.sty:${PORTSDIR}/print/texlive-impnattypo \
		${LOCALBASE}/share/texmf-dist/tex/latex/mafr/mafr.sty:${PORTSDIR}/print/texlive-mafr \
		${LOCALBASE}/share/texmf-dist/tex/latex/tabvar/tabvar.sty:${PORTSDIR}/print/texlive-tabvar \
		${LOCALBASE}/share/texmf-dist/tex/latex/tdsfrmath/tdsfrmath.sty:${PORTSDIR}/print/texlive-tdsfrmath \
		${LOCALBASE}/share/texmf-dist/tex/generic/variations/variations.sty:${PORTSDIR}/print/texlive-variations

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
