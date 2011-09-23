# New ports collection makefile for:	texlive-texliveonfly
# Date created:		09/23/2011 04:41:58
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	texliveonfly
PORTVERSION=	20110923
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	On-the-fly download of missing TeX live packages.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
