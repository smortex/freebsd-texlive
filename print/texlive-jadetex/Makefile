# $FreeBSD$

PORTNAME=	jadetex
PORTVERSION=	20140428
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Macros supporting Jade DSSSL output.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/passivetex/dummyels.sty:${PORTSDIR}/print/texlive-passivetex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
