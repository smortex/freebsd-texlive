# New ports collection makefile for:	texlive-ctie
# Date created:		13/03/2010 04:23:57
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	ctie
PORTVERSION=	20120529
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	C version of tie (merging Web change files).

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
