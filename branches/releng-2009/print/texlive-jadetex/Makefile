# New ports collection makefile for:	texlive-jadetex
# Date created:		13/03/2010 04:31:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	jadetex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Macros supporting Jade DSSSL output.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
