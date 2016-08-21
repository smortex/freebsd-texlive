# $FreeBSD$

PORTNAME=	collection-plainextra
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Plain TeX packages

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
		${LOCALBASE}/share/texmf-dist/tex/plain/epsf-dvipdfmx/epsf-dvipdfmx.tex:${PORTSDIR}/print/texlive-epsf-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/plain/figflow/figflow.tex:${PORTSDIR}/print/texlive-figflow \
		${LOCALBASE}/share/texmf-dist/tex/plain/fixpdfmag/fixpdfmag.tex:${PORTSDIR}/print/texlive-fixpdfmag \
		${LOCALBASE}/share/texmf-dist/tex/plain/font-change/default-amssymbols.tex:${PORTSDIR}/print/texlive-font-change \
		${LOCALBASE}/share/texmf-dist/tex/plain/fontch/fontch.tex:${PORTSDIR}/print/texlive-fontch \
		${LOCALBASE}/share/texmf-dist/tex/plain/getoptk/getoptk.tex:${PORTSDIR}/print/texlive-getoptk \
		${LOCALBASE}/share/texmf-dist/tex/plain/gfnotation/GFnotation.tex:${PORTSDIR}/print/texlive-gfnotation \
		${LOCALBASE}/share/texmf-dist/tex/plain/graphics-pln/autopict.sty:${PORTSDIR}/print/texlive-graphics-pln \
		${LOCALBASE}/share/texmf-dist/tex/plain/hyplain/hyplain.tex:${PORTSDIR}/print/texlive-hyplain \
		${LOCALBASE}/share/texmf-dist/tex/plain/js-misc/js-misc.tex:${PORTSDIR}/print/texlive-js-misc \
		${LOCALBASE}/share/texmf-dist/tex/plain/mkpattern/mkpatter.tex:${PORTSDIR}/print/texlive-mkpattern \
		${LOCALBASE}/share/texmf-dist/tex/plain/newsletr/newsletr.tex:${PORTSDIR}/print/texlive-newsletr \
		${LOCALBASE}/share/texmf-dist/tex/plain/pitex/pitex.tex:${PORTSDIR}/print/texlive-pitex \
		${LOCALBASE}/share/texmf-dist/tex/plain/placeins-plain/placeins.tex:${PORTSDIR}/print/texlive-placeins-plain \
		${LOCALBASE}/share/texmf-dist/tex/plain/plipsum/plipsum.tex:${PORTSDIR}/print/texlive-plipsum \
		${LOCALBASE}/share/texmf-dist/tex/plain/plnfss/plnfss.tex:${PORTSDIR}/print/texlive-plnfss \
		${LOCALBASE}/share/texmf-dist/tex/plain/plstmary/stmary.tex:${PORTSDIR}/print/texlive-plstmary \
		${LOCALBASE}/share/texmf-dist/tex/plain/present/present.tex:${PORTSDIR}/print/texlive-present \
		${LOCALBASE}/share/texmf-dist/tex/plain/resumemac/resumemac.tex:${PORTSDIR}/print/texlive-resumemac \
		${LOCALBASE}/share/texmf-dist/tex/texinfo/texinfo.tex:${PORTSDIR}/print/texlive-texinfo \
		${LOCALBASE}/share/texmf-dist/tex/plain/timetable/timetable.tex:${PORTSDIR}/print/texlive-timetable \
		${LOCALBASE}/share/texmf-dist/tex/plain/treetex/treetex.tex:${PORTSDIR}/print/texlive-treetex \
		${LOCALBASE}/share/texmf-dist/tex/plain/varisize/10point.tex:${PORTSDIR}/print/texlive-varisize

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
