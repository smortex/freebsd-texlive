# New ports collection makefile for:	texlive-mkjobtexmf
# Date created:		26/01/2009 16:03:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	mkjobtexmf
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Generate a texmf tree for a particular job.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
