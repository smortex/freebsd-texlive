# New ports collection makefile for:	texlive-texdirflatten
# Date created:		13/03/2010 04:24:27
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texdirflatten
PORTVERSION=	20100921
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Collect files related to a LaTeX job in a single directory.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
