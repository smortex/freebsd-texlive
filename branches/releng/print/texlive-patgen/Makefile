# New ports collection makefile for:	texlive-patgen
# Date created:		13/03/2010 04:24:17
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	patgen
PORTVERSION=	20110427
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The patgen package

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
