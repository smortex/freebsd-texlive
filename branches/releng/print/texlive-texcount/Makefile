# New ports collection makefile for:	texlive-texcount
# Date created:		13/03/2010 04:24:25
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texcount
PORTVERSION=	20120515
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Count words in a LaTeX document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
