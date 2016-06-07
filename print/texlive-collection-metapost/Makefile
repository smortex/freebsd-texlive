# $FreeBSD$

PORTNAME=	collection-metapost
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	MetaPost and Metafont packages

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
		${LOCALBASE}/share/texmf-dist/tex/generic/tex-ini-files/dvilualatex.ini:${PORTSDIR}/print/texlive-tex-ini-files \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/tex/generic/unicode-data/CaseFolding.txt:${PORTSDIR}/print/texlive-unicode-data \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/updmap/kanjix.map:${PORTSDIR}/print/texlive-updmap-map \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/metapost/automata/automata.mp:${PORTSDIR}/print/texlive-automata \
		${LOCALBASE}/share/texmf-dist/metapost/bbcard/bbcard.mp:${PORTSDIR}/print/texlive-bbcard \
		${LOCALBASE}/share/texmf-dist/metapost/blockdraw_mp/blockdraw.mp:${PORTSDIR}/print/texlive-blockdraw_mp \
		${LOCALBASE}/share/texmf-dist/metapost/bpolynomial/bpolynomial.mp:${PORTSDIR}/print/texlive-bpolynomial \
		${LOCALBASE}/share/texmf-dist/metapost/cmarrows/cmarrows.mp:${PORTSDIR}/print/texlive-cmarrows \
		${LOCALBASE}/share/texmf-dist/metapost/drv/drv.mp:${PORTSDIR}/print/texlive-drv \
		${LOCALBASE}/share/texmf-dist/metapost/dviincl/fix_brks.mp:${PORTSDIR}/print/texlive-dviincl \
		${LOCALBASE}/share/texmf-dist/tex/latex/emp/emp.sty:${PORTSDIR}/print/texlive-emp \
		${LOCALBASE}/share/texmf-dist/metapost/epsincl/epsincl.mp:${PORTSDIR}/print/texlive-epsincl \
		${LOCALBASE}/share/texmf-dist/metapost/expressg/aam.mp:${PORTSDIR}/print/texlive-expressg \
		${LOCALBASE}/share/texmf-dist/metapost/exteps/exteps.mp:${PORTSDIR}/print/texlive-exteps \
		${LOCALBASE}/share/texmf-dist/metapost/featpost/featpost.mp:${PORTSDIR}/print/texlive-featpost \
		${LOCALBASE}/share/texmf-dist/tex/latex/feynmf/feynmf.sty:${PORTSDIR}/print/texlive-feynmf \
		${LOCALBASE}/share/texmf-dist/tex/latex/feynmp-auto/feynmp-auto.sty:${PORTSDIR}/print/texlive-feynmp-auto \
		${LOCALBASE}/share/texmf-dist/metapost/garrigues/garrigues.mp:${PORTSDIR}/print/texlive-garrigues \
		${LOCALBASE}/share/texmf-dist/tex/latex/gmp/gmp.sty:${PORTSDIR}/print/texlive-gmp \
		${LOCALBASE}/share/texmf-dist/metapost/hatching/hatching.mp:${PORTSDIR}/print/texlive-hatching \
		${LOCALBASE}/share/texmf-dist/metapost/latexmp/latexmp.mp:${PORTSDIR}/print/texlive-latexmp \
		${LOCALBASE}/share/texmf-dist/metapost/mcf2graph/mcf2graph.mf:${PORTSDIR}/print/texlive-mcf2graph \
		${LOCALBASE}/share/texmf-dist/metapost/metago/metago.mp:${PORTSDIR}/print/texlive-metago \
		${LOCALBASE}/share/texmf-dist/metapost/metaobj/connections.mp:${PORTSDIR}/print/texlive-metaobj \
		${LOCALBASE}/share/texmf-dist/metapost/metaplot/axes.mp:${PORTSDIR}/print/texlive-metaplot \
		${LOCALBASE}/share/texmf-dist/fonts/afm/metapost/freeeuro.afm:${PORTSDIR}/print/texlive-metapost \
		${LOCALBASE}/share/texmf-dist/metapost/metauml/metauml.mp:${PORTSDIR}/print/texlive-metauml \
		${LOCALBASE}/share/texmf-dist/tex/generic/mfpic/mfpic.sty:${PORTSDIR}/print/texlive-mfpic \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfpic4ode/mfpic4ode.sty:${PORTSDIR}/print/texlive-mfpic4ode \
		${LOCALBASE}/share/texmf-dist/metapost/mp3d/3d.mp:${PORTSDIR}/print/texlive-mp3d \
		${LOCALBASE}/share/texmf-dist/metapost/mparrows/mparrows.mp:${PORTSDIR}/print/texlive-mparrows \
		${LOCALBASE}/share/texmf-dist/metapost/mpattern/mpattern.mp:${PORTSDIR}/print/texlive-mpattern \
		${LOCALBASE}/share/texmf-dist/metapost/mpcolornames/mpcolornames-spec-dvipsnam-def.mp:${PORTSDIR}/print/texlive-mpcolornames \
		${LOCALBASE}/share/texmf-dist/tex/latex/mpgraphics/mpgraphics.sty:${PORTSDIR}/print/texlive-mpgraphics \
		${LOCALBASE}/share/texmf-dist/metapost/piechartmp/piechartmp.mp:${PORTSDIR}/print/texlive-piechartmp \
		${LOCALBASE}/share/texmf-dist/metapost/repere/repere.mp:${PORTSDIR}/print/texlive-repere \
		${LOCALBASE}/share/texmf-dist/metafont/roex/roex.mf:${PORTSDIR}/print/texlive-roex \
		${LOCALBASE}/share/texmf-dist/metapost/roundrect/roundrect.mp:${PORTSDIR}/print/texlive-roundrect \
		${LOCALBASE}/share/texmf-dist/metapost/shapes/shapes.mp:${PORTSDIR}/print/texlive-shapes \
		${LOCALBASE}/share/texmf-dist/metapost/slideshow/pathalong.mp:${PORTSDIR}/print/texlive-slideshow \
		${LOCALBASE}/share/texmf-dist/metapost/splines/splines.mp:${PORTSDIR}/print/texlive-splines \
		${LOCALBASE}/share/texmf-dist/metapost/suanpan/abacus.mp:${PORTSDIR}/print/texlive-suanpan \
		${LOCALBASE}/share/texmf-dist/metapost/textpath/textpath.mp:${PORTSDIR}/print/texlive-textpath \
		${LOCALBASE}/share/texmf-dist/metapost/threeddice/threeddice.mp:${PORTSDIR}/print/texlive-threeddice

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
