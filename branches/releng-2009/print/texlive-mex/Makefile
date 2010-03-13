# New ports collection makefile for:	texlive-mex
# Date created:		13/03/2010 04:37:50
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	mex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Polish formats for TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/pl/config.pl:${PORTSDIR}/print/texlive-pl \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
