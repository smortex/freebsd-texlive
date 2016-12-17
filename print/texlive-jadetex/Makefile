# $FreeBSD$

PORTNAME=	jadetex
PORTVERSION=	20160718
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Macros supporting Jade DSSSL output

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/passivetex/dummyels.sty:${PORTSDIR}/print/texlive-passivetex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/tex/latex/colortbl/colortbl.sty:${PORTSDIR}/print/texlive-colortbl \
		${LOCALBASE}/share/texmf-dist/tex/latex/cyrillic/cp1251.def:${PORTSDIR}/print/texlive-cyrillic \
		${LOCALBASE}/share/texmf-dist/fonts/source/jknappen/ec/ecbi.mf:${PORTSDIR}/print/texlive-ec \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyhdr/fancyhdr.sty:${PORTSDIR}/print/texlive-fancyhdr \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics/graphics.sty:${PORTSDIR}/print/texlive-graphics \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics-cfg/color.cfg:${PORTSDIR}/print/texlive-graphics-cfg \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics-def/dvipdfmx.def:${PORTSDIR}/print/texlive-graphics-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/hyperref/hyperref.sty:${PORTSDIR}/print/texlive-hyperref \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/epstopdf-sys.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/marvosym/marvosym.sty:${PORTSDIR}/print/texlive-marvosym \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/oberdiek/oberdiek-bundle.bib:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/stmaryrd/stmaryrd.sty:${PORTSDIR}/print/texlive-stmaryrd \
		${LOCALBASE}/share/texmf-dist/dvips/symbol/config.usy:${PORTSDIR}/print/texlive-symbol \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex-ini-files/dvilualatex.ini:${PORTSDIR}/print/texlive-tex-ini-files \
		${LOCALBASE}/share/texmf-dist/tex/latex/tipa/tipa.sty:${PORTSDIR}/print/texlive-tipa \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf-dist/tex/generic/ulem/ulem.sty:${PORTSDIR}/print/texlive-ulem \
		${LOCALBASE}/share/texmf-dist/tex/latex/url/url.sty:${PORTSDIR}/print/texlive-url \
		${LOCALBASE}/share/texmf-dist/tex/latex/wasysym/wasysym.sty:${PORTSDIR}/print/texlive-wasysym \
		${LOCALBASE}/share/texmf-dist/dvips/zapfding/config.uzd:${PORTSDIR}/print/texlive-zapfding

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
